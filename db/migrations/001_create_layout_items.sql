-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (level, weight, token, label, active) VALUES (48, 67.35, 'stable', 'fallback', 84);
INSERT INTO layout_items (level, weight, token, label, active) VALUES (85, 14.1, 'primary', 'edge', 28);
INSERT INTO layout_items (level, weight, token, label, active) VALUES (63, 29.4, 'local', 'staging', 85);
