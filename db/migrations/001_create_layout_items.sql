-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, weight, active, ratio) VALUES (79, 62.41, 27, 84.92);
INSERT INTO layout_items (level, weight, active, ratio) VALUES (35, 86.43, 32, 85.83);
INSERT INTO layout_items (level, weight, active, ratio) VALUES (63, 51.95, 61, 33.63);
