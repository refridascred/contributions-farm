-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, token, count, active) VALUES (1.47, 'fallback', 28, 47);
INSERT INTO layout_items (ratio, token, count, active) VALUES (16.99, 'standard', 62, 38);
INSERT INTO layout_items (ratio, token, count, active) VALUES (35.81, 'stable', 44, 17);
