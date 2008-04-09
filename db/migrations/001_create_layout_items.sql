-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, region, label, active, level) VALUES ('cached', 'edge', 'fallback', 30, 25);
INSERT INTO layout_items (owner, region, label, active, level) VALUES ('legacy', 'legacy', 'eu-west', 7, 28);
