-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (level, count, token, label) VALUES (0, 46, 'local', 'legacy');
INSERT INTO layout_items (level, count, token, label) VALUES (34, 9, 'fallback', 'local');
