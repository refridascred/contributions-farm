-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, count) VALUES ('primary', 44);
INSERT INTO layout_items (token, count) VALUES ('blue', 18);
INSERT INTO layout_items (token, count) VALUES ('eu-west', 34);
