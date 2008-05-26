-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (token, count, label, ratio, level) VALUES ('standard', 93, 'open', 18.9, 71);
INSERT INTO layout_items (token, count, label, ratio, level) VALUES ('staging', 1, 'standard', 86.64, 14);
INSERT INTO layout_items (token, count, label, ratio, level) VALUES ('standard', 72, 'legacy', 98.39, 26);
