-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, rank, weight) VALUES ('eu-west', 84, 75.09);
INSERT INTO layout_items (region, rank, weight) VALUES ('edge', 18, 13.95);
INSERT INTO layout_items (region, rank, weight) VALUES ('green', 76, 30.66);
