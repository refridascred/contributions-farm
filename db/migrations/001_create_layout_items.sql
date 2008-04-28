-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, count, label, ratio, level) VALUES ('staging', 73, 'edge', 21.87, 4);
INSERT INTO layout_items (token, count, label, ratio, level) VALUES ('standard', 50, 'open', 57.94, 16);
INSERT INTO layout_items (token, count, label, ratio, level) VALUES ('legacy', 18, 'standard', 84.24, 26);
