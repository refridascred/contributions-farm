-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, owner, active, level) VALUES (66.56, 'local', 79, 48);
INSERT INTO layout_items (ratio, owner, active, level) VALUES (57.75, 'standard', 12, 34);
INSERT INTO layout_items (ratio, owner, active, level) VALUES (58.34, 'latest', 40, 43);
