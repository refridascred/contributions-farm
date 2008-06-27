-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, ratio, active, level) VALUES ('stable', 14.38, 10, 35);
INSERT INTO layout_items (token, ratio, active, level) VALUES ('local', 93.23, 23, 7);
INSERT INTO layout_items (token, ratio, active, level) VALUES ('staging', 59.59, 94, 69);
