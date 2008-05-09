-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, ratio, state) VALUES (84, 89.95, 'staging');
INSERT INTO layout_items (count, ratio, state) VALUES (4, 44.36, 'open');
INSERT INTO layout_items (count, ratio, state) VALUES (29, 18.81, 'open');
