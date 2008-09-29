-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, active, level) VALUES (59.37, 24, 25);
INSERT INTO layout_items (score, active, level) VALUES (25.98, 49, 43);
INSERT INTO layout_items (score, active, level) VALUES (11.01, 78, 26);
