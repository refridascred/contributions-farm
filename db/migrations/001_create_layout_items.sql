-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, owner, region, level, active) VALUES (53.22, 'legacy', 'fallback', 75, 22);
INSERT INTO layout_items (ratio, owner, region, level, active) VALUES (24.46, 'legacy', 'fallback', 10, 41);
