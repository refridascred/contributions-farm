-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, rank, score) VALUES ('green', 89, 40.73);
INSERT INTO layout_items (region, rank, score) VALUES ('legacy', 66, 33.9);
INSERT INTO layout_items (region, rank, score) VALUES ('legacy', 83, 5.72);
