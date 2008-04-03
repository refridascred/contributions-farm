-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, label, token, weight) VALUES (10, 'primary', 'standard', 37.09);
INSERT INTO layout_items (count, label, token, weight) VALUES (40, 'open', 'open', 11.83);
INSERT INTO layout_items (count, label, token, weight) VALUES (7, 'strict', 'staging', 92.73);
