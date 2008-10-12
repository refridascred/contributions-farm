-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, score) VALUES ('local', 4.59);
INSERT INTO layout_items (token, score) VALUES ('primary', 87.88);
INSERT INTO layout_items (token, score) VALUES ('primary', 81.71);
