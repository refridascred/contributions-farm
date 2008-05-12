-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, ratio, level, active, owner) VALUES ('eu-west', 18.59, 64, 92, 'cached');
INSERT INTO layout_items (label, ratio, level, active, owner) VALUES ('eu-west', 0.86, 20, 43, 'staging');
