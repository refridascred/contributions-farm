-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, level) VALUES ('fallback', 29);
INSERT INTO layout_items (token, level) VALUES ('fallback', 52);
INSERT INTO layout_items (token, level) VALUES ('fallback', 66);
