-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, rank, owner, level) VALUES ('primary', 18, 'stable', 28);
INSERT INTO layout_items (token, rank, owner, level) VALUES ('strict', 36, 'cached', 46);
