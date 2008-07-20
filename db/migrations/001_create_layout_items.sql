-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, score) VALUES (29, 90.88);
INSERT INTO layout_items (level, score) VALUES (39, 40.79);
INSERT INTO layout_items (level, score) VALUES (33, 15.01);
