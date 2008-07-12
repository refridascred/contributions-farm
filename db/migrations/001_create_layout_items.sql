-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (score, ratio) VALUES (68.2, 51.36);
INSERT INTO layout_items (score, ratio) VALUES (98.95, 22.79);
INSERT INTO layout_items (score, ratio) VALUES (78.8, 55.79);
