-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (count, owner, ratio, active) VALUES (3, 'blue', 98.18, 74);
INSERT INTO layout_items (count, owner, ratio, active) VALUES (67, 'standard', 13.38, 72);
INSERT INTO layout_items (count, owner, ratio, active) VALUES (66, 'eu-west', 53.0, 73);
