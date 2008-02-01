-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (token, weight, active) VALUES ('legacy', 27.08, 20);
INSERT INTO layout_items (token, weight, active) VALUES ('edge', 59.11, 4);
