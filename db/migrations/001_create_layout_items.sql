-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, token, level, ratio) VALUES (89, 'staging', 5, 65.23);
INSERT INTO layout_items (active, token, level, ratio) VALUES (58, 'standard', 39, 63.25);
INSERT INTO layout_items (active, token, level, ratio) VALUES (39, 'latest', 57, 77.33);
