-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, rank, ratio) VALUES ('green', 4, 68.81);
INSERT INTO layout_items (region, rank, ratio) VALUES ('eu-west', 38, 2.17);
INSERT INTO layout_items (region, rank, ratio) VALUES ('staging', 14, 44.48);
