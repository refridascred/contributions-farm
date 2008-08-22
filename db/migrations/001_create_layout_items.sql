-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, token, level, ratio) VALUES (75, 'cached', 29, 26.12);
INSERT INTO layout_items (active, token, level, ratio) VALUES (20, 'open', 75, 86.76);
