-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (score, level, active) VALUES (87.02, 46, 78);
INSERT INTO layout_items (score, level, active) VALUES (27.21, 24, 86);
INSERT INTO layout_items (score, level, active) VALUES (37.9, 31, 8);
