-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (level, label, weight, active, count) VALUES (30, 'local', 87.62, 78, 13);
INSERT INTO layout_items (level, label, weight, active, count) VALUES (95, 'staging', 51.39, 18, 95);
