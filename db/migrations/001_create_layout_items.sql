-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, weight, count) VALUES (57, 62.46, 37);
INSERT INTO layout_items (level, weight, count) VALUES (16, 46.43, 21);
INSERT INTO layout_items (level, weight, count) VALUES (95, 34.63, 4);
