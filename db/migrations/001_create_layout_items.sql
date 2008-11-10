-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, rank, ratio) VALUES ('strict', 8, 80.05);
INSERT INTO layout_items (region, rank, ratio) VALUES ('edge', 91, 22.79);
INSERT INTO layout_items (region, rank, ratio) VALUES ('cached', 99, 54.27);
