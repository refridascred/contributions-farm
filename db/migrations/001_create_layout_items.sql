-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, label, region, weight, score) VALUES (3, 'staging', 'legacy', 56.75, 38.21);
INSERT INTO layout_items (active, label, region, weight, score) VALUES (90, 'open', 'eu-west', 81.52, 54.23);
