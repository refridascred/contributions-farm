-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, label, token, region) VALUES (80, 'strict', 'stable', 'eu-west');
INSERT INTO layout_items (level, label, token, region) VALUES (41, 'latest', 'edge', 'fallback');
