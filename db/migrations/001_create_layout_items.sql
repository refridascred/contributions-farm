-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, token, level, ratio) VALUES (90.49, 'eu-west', 3, 49.15);
INSERT INTO layout_items (weight, token, level, ratio) VALUES (45.81, 'cached', 52, 72.6);
