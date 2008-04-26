-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, count, label, token, active) VALUES (24.76, 83, 'local', 'strict', 64);
INSERT INTO layout_items (ratio, count, label, token, active) VALUES (66.76, 27, 'stable', 'local', 54);
INSERT INTO layout_items (ratio, count, label, token, active) VALUES (1.63, 64, 'green', 'green', 2);
