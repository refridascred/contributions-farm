-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (active, ratio, label, weight) VALUES (1, 30.3, 'stable', 26.63);
INSERT INTO layout_items (active, ratio, label, weight) VALUES (49, 30.59, 'eu-west', 34.36);
INSERT INTO layout_items (active, ratio, label, weight) VALUES (42, 87.59, 'standard', 96.14);
