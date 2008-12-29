-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, label, level, score) VALUES ('stable', 'open', 7, 69.88);
INSERT INTO layout_items (owner, label, level, score) VALUES ('edge', 'stable', 75, 40.97);
