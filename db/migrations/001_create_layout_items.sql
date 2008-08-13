-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, level, label, active) VALUES (72, 53, 'fallback', 91);
INSERT INTO layout_items (count, level, label, active) VALUES (80, 67, 'staging', 78);
INSERT INTO layout_items (count, level, label, active) VALUES (14, 85, 'local', 23);
