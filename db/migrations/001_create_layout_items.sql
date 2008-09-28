-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, token, count, ratio) VALUES (22, 'eu-west', 85, 18.92);
INSERT INTO layout_items (level, token, count, ratio) VALUES (23, 'cached', 6, 63.9);
INSERT INTO layout_items (level, token, count, ratio) VALUES (21, 'edge', 35, 2.81);
