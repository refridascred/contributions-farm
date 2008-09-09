-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, weight, active, score) VALUES (39, 48.92, 87, 7.06);
INSERT INTO layout_items (level, weight, active, score) VALUES (50, 79.9, 16, 58.56);
INSERT INTO layout_items (level, weight, active, score) VALUES (4, 62.37, 14, 84.94);
