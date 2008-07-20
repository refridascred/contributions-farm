-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, weight, token, owner) VALUES (63, 16.52, 'stable', 'stable');
INSERT INTO layout_items (level, weight, token, owner) VALUES (67, 61.16, 'strict', 'strict');
INSERT INTO layout_items (level, weight, token, owner) VALUES (64, 60.19, 'cached', 'eu-west');
