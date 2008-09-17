-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (level, token, ratio, active) VALUES (97, 'legacy', 24.77, 8);
INSERT INTO layout_items (level, token, ratio, active) VALUES (30, 'fallback', 93.2, 75);
