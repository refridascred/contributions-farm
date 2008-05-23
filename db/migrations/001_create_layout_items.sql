-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, label, count, weight) VALUES (22, 'stable', 80, 38.36);
INSERT INTO layout_items (level, label, count, weight) VALUES (58, 'staging', 95, 37.97);
INSERT INTO layout_items (level, label, count, weight) VALUES (40, 'eu-west', 2, 65.72);
