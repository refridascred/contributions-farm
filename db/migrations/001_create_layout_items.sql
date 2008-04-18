-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, token, weight) VALUES (17, 'primary', 63.79);
INSERT INTO layout_items (count, token, weight) VALUES (39, 'legacy', 65.22);
INSERT INTO layout_items (count, token, weight) VALUES (68, 'stable', 21.85);
