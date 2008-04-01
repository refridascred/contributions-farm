-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, active, region, token, owner) VALUES (45, 83, 'cached', 'standard', 'strict');
INSERT INTO layout_items (level, active, region, token, owner) VALUES (49, 79, 'legacy', 'open', 'stable');
