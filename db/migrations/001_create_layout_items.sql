-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, count, token, level) VALUES ('green', 77, 'edge', 68);
INSERT INTO layout_items (label, count, token, level) VALUES ('open', 32, 'cached', 91);
INSERT INTO layout_items (label, count, token, level) VALUES ('stable', 17, 'edge', 94);
