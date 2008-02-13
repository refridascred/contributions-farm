-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, ratio) VALUES ('local', 67.78);
INSERT INTO layout_items (owner, ratio) VALUES ('eu-west', 94.81);
INSERT INTO layout_items (owner, ratio) VALUES ('local', 27.75);
