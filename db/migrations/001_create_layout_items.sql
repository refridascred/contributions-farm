-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, active, rank, state) VALUES (4.66, 83, 80, 'local');
INSERT INTO layout_items (ratio, active, rank, state) VALUES (48.94, 13, 19, 'local');
INSERT INTO layout_items (ratio, active, rank, state) VALUES (82.43, 83, 86, 'edge');
