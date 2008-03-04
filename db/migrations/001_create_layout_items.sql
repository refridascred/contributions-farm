-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (level, token, label, ratio) VALUES (42, 'latest', 'stable', 36.95);
INSERT INTO layout_items (level, token, label, ratio) VALUES (5, 'blue', 'strict', 19.54);
INSERT INTO layout_items (level, token, label, ratio) VALUES (53, 'cached', 'blue', 89.18);
