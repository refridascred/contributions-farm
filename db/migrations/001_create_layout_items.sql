-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (count, ratio, state) VALUES (30, 5.86, 'local');
INSERT INTO layout_items (count, ratio, state) VALUES (87, 46.43, 'local');
INSERT INTO layout_items (count, ratio, state) VALUES (45, 65.5, 'staging');
