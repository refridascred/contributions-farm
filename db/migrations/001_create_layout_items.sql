-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, count, weight, token) VALUES (29, 4, 52.66, 'staging');
INSERT INTO layout_items (level, count, weight, token) VALUES (72, 4, 94.92, 'blue');
INSERT INTO layout_items (level, count, weight, token) VALUES (83, 69, 47.42, 'stable');
