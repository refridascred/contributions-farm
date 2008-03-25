-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, label, rank) VALUES (52.13, 'edge', 84);
INSERT INTO layout_items (ratio, label, rank) VALUES (3.84, 'standard', 30);
INSERT INTO layout_items (ratio, label, rank) VALUES (61.91, 'primary', 36);
