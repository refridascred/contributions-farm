-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, weight, region, active) VALUES (89, 3.1, 'latest', 70);
INSERT INTO layout_items (level, weight, region, active) VALUES (12, 89.03, 'cached', 2);
INSERT INTO layout_items (level, weight, region, active) VALUES (30, 53.46, 'standard', 78);
