-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, token, active) VALUES (13.91, 'blue', 35);
INSERT INTO layout_items (weight, token, active) VALUES (12.45, 'primary', 94);
INSERT INTO layout_items (weight, token, active) VALUES (71.77, 'fallback', 68);
