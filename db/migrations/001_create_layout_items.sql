-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, label, level, owner, active) VALUES (65.47, 'staging', 78, 'staging', 70);
INSERT INTO layout_items (weight, label, level, owner, active) VALUES (66.9, 'edge', 92, 'eu-west', 53);
INSERT INTO layout_items (weight, label, level, owner, active) VALUES (98.89, 'legacy', 20, 'strict', 35);
