-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, level, token, active, score) VALUES ('fallback', 96, 'eu-west', 49, 67.14);
INSERT INTO layout_items (region, level, token, active, score) VALUES ('fallback', 20, 'primary', 7, 85.72);
