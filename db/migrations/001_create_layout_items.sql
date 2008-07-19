-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, ratio, rank) VALUES ('edge', 64.44, 54);
INSERT INTO layout_items (region, ratio, rank) VALUES ('standard', 78.4, 65);
INSERT INTO layout_items (region, ratio, rank) VALUES ('edge', 57.42, 88);
