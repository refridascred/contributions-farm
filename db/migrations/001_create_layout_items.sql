-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, count, token, state) VALUES (13.23, 95, 'stable', 'staging');
INSERT INTO layout_items (ratio, count, token, state) VALUES (3.33, 3, 'blue', 'blue');
INSERT INTO layout_items (ratio, count, token, state) VALUES (52.02, 82, 'staging', 'open');
