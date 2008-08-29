-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, active, region, owner) VALUES (63.14, 73, 'stable', 'latest');
INSERT INTO layout_items (weight, active, region, owner) VALUES (13.67, 78, 'blue', 'fallback');
INSERT INTO layout_items (weight, active, region, owner) VALUES (18.15, 28, 'primary', 'local');
