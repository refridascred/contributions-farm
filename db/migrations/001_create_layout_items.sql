-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (active, token, level, ratio) VALUES (58, 'staging', 29, 74.18);
INSERT INTO layout_items (active, token, level, ratio) VALUES (90, 'strict', 89, 5.17);
INSERT INTO layout_items (active, token, level, ratio) VALUES (60, 'standard', 67, 10.25);
