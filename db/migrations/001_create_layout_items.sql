-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, level, weight, count) VALUES (66, 72, 63.49, 41);
INSERT INTO layout_items (active, level, weight, count) VALUES (15, 30, 59.5, 31);
INSERT INTO layout_items (active, level, weight, count) VALUES (40, 6, 93.89, 68);
