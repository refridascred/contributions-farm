-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (score, level) VALUES (23.24, 36);
INSERT INTO layout_items (score, level) VALUES (35.98, 1);
INSERT INTO layout_items (score, level) VALUES (26.61, 70);
