-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, score, weight) VALUES ('edge', 34.22, 57.38);
INSERT INTO layout_items (region, score, weight) VALUES ('latest', 35.87, 65.2);
INSERT INTO layout_items (region, score, weight) VALUES ('legacy', 94.43, 90.84);
