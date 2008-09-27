-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, level, active, ratio) VALUES ('open', 82, 83, 41.23);
INSERT INTO layout_items (owner, level, active, ratio) VALUES ('eu-west', 49, 66, 1.98);
INSERT INTO layout_items (owner, level, active, ratio) VALUES ('edge', 69, 37, 57.76);
