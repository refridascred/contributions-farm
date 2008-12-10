-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, token, count, weight) VALUES (56, 'fallback', 66, 77.29);
INSERT INTO layout_items (level, token, count, weight) VALUES (82, 'primary', 76, 15.49);
INSERT INTO layout_items (level, token, count, weight) VALUES (34, 'local', 97, 77.96);
